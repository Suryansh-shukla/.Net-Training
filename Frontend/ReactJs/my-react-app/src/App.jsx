import './App.css'

function App() {
  return (
    <div className="page-shell">
      <header className="network-header" aria-label="Top navigation">
        <div className="brand">
          <span className="brand-mark" aria-hidden="true">in</span>
          <span className="brand-name">indices</span>
        </div>

        <form className="search" role="search" onSubmit={(e) => e.preventDefault()}>
          <input
            type="search"
            placeholder="Search"
            aria-label="Search"
          />
        </form>

        <nav className="top-nav" aria-label="Main menu">
          <a href="#" aria-current="page">Home</a>
          <a href="#">My Network</a>
          <a href="#">Jobs</a>
          <a href="#">Messaging</a>
          <a href="#">Notifications</a>
          <button type="button" className="profile-chip">Me</button>
        </nav>
      </header>

      <main className="content">
        <section className="hero-card">
          <h1>Indices Professional Hub</h1>
          <p>
            This header is LinkedIn-inspired and fully editable for your project.
          </p>
        </section>
      </main>
    </div>
  )
}

export default App
