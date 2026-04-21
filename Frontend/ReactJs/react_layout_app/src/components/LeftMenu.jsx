function LeftMenu({ title, items }) {
  return (
    <aside className="left-menu card-panel">
      <h2>{title}</h2>
      <ul className="menu-list">
        {items.map((item) => (
          <li key={item}>
            <a href="#">{item}</a>
          </li>
        ))}
      </ul>
    </aside>
  );
}

export default LeftMenu;
