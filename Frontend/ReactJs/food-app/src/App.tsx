import { useState } from "react";

type FoodItem = {
  id: number;
  name: string;
  price: number;
  image: string;
};

const initialItems: FoodItem[] = [
  {
    id: 1,
    name: "Pizza",
    price: 299,
    image: "https://images.unsplash.com/photo-1601924582975-7e6b2d1b4c61",
  },
  {
    id: 2,
    name: "Burger",
    price: 149,
    image: "https://images.unsplash.com/photo-1550547660-d9450f859349",
  },
];

export default function App() {
  const [items, setItems] = useState<FoodItem[]>(initialItems);
  const [form, setForm] = useState({
    name: "",
    price: "",
    image: "",
  });

  const handleChange = (e: React.ChangeEvent<HTMLInputElement>) => {
    setForm({ ...form, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e: React.FormEvent) => {
    e.preventDefault();

    if (!form.name || !form.price || !form.image) return;

    const newItem: FoodItem = {
      id: Date.now(),
      name: form.name,
      price: Number(form.price),
      image: form.image,
    };

    setItems([...items, newItem]);
    setForm({ name: "", price: "", image: "" });
  };

  return (
    <div className="min-h-screen bg-gray-100 p-6">
      <h1 className="text-3xl font-bold text-center mb-6">🍔 Food Menu</h1>

      <form
        onSubmit={handleSubmit}
        className="bg-white p-4 rounded-2xl shadow-md mb-6 max-w-md mx-auto"
      >
        <h2 className="text-xl font-semibold mb-3">Add Food Item</h2>

        <input
          type="text"
          name="name"
          placeholder="Food Name"
          value={form.name}
          onChange={handleChange}
          className="w-full border p-2 mb-2 rounded"
        />

        <input
          type="number"
          name="price"
          placeholder="Price"
          value={form.price}
          onChange={handleChange}
          className="w-full border p-2 mb-2 rounded"
        />

        <input
          type="text"
          name="image"
          placeholder="Image URL"
          value={form.image}
          onChange={handleChange}
          className="w-full border p-2 mb-3 rounded"
        />

        <button
          type="submit"
          className="w-full bg-purple-600 text-white py-2 rounded-xl hover:bg-purple-700"
        >
          Add Item
        </button>
      </form>

      <div className="grid grid-cols-1 sm:grid-cols-2 md:grid-cols-3 gap-6">
        {items.map((item) => (
          <div
            key={item.id}
            className="bg-white rounded-2xl shadow-md overflow-hidden"
          >
            <img
              src={item.image}
              alt={item.name}
              className="w-full h-40 object-cover"
            />
            <div className="p-4">
              <h3 className="text-lg font-semibold">{item.name}</h3>
              <p className="text-gray-600">₹{item.price}</p>
            </div>
          </div>
        ))}
      </div>
    </div>
  );
}