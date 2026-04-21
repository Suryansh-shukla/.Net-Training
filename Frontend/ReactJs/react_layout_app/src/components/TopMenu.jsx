function TopMenu({ companyName }) {
  return (
    <header className="top-menu">
      <div className="brand-block">
        <span className="brand-logo">IT</span>
        <div>
          <div className="brand-name">{companyName}</div>
          <div className="brand-subtitle">Learn • Practice • Grow</div>
        </div>
      </div>

      <nav className="top-nav">
        <a href="#">Home</a>
        <a href="#">Courses</a>
        <a href="#">Tutorials</a>
        <a href="#">Contact</a>
      </nav>
    </header>
  );
}

export default TopMenu;
