namespace day6demo3;

public class HeightCategory
{
    public int heightCM;
    public string GetHeightCategory()
    {
        if (heightCM < 150)
        {
            return "Short";
        }
        else if (heightCM >= 150 && heightCM <180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }
    public static void Main(){
            HeightCategory heightCategory = new HeightCategory();
            Console.WriteLine("Enter Height in CM:");
            heightCategory.heightCM=int.Parse(Console.ReadLine());
            string category=heightCategory.GetHeightCategory();
            Console.WriteLine($"Height Category: {category}");
        }
}
