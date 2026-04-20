// import './App.css'

// function App() {
//   return (
//     <div className="page-shell">
//       <header className="network-header" aria-label="Top navigation">
//         <div className="brand">
//           <span className="brand-mark" aria-hidden="true">in</span>
//           <span className="brand-name">indices</span>
//         </div>

//         <form className="search" role="search" onSubmit={(e) => e.preventDefault()}>
//           <input
//             type="search"
//             placeholder="Search"
//             aria-label="Search"
//           />
//         </form>

//         <nav className="top-nav" aria-label="Main menu">
//           <a href="#" aria-current="page">Home</a>
//           <a href="#">My Network</a>
//           <a href="#">Jobs</a>
//           <a href="#">Messaging</a>
//           <a href="#">Notifications</a>
//           <button type="button" className="profile-chip">Me</button>
//         </nav>
//       </header>

//       <main className="content">
//         <section className="hero-card">
//           <h1>Indices Professional Hub</h1>
//           <p>
//             This header is LinkedIn-inspired and fully editable for your project.
//           </p>
//         </section>
//       </main>
//     </div>
//   )
// }

// export default App

// import { useState } from 'react'
// import viteLogo from './assets/vite.svg'
// import './App.css'

// function App() {
//   const [count, setCount] = useState(0)
  
//   return (
//     <div className="App">
//       <div>
//         <h1>Welcome</h1>
//       </div>
//       </div>
//       )
//     }
//     export default App


import React from "react";
import "./index.css";

// Header
const Header = () => <div className="header">Header</div>;

// Navigation
const Navigation = () => <div className="nav">Navigation</div>;

// Sidebar
const Sidebar = () => <div className="sidebar">Sidebar</div>;

// Main Content
const MainContent = () => <div className="main">Main Content</div>;

// Ads Section
const Ads = () => <div className="ads">Ads</div>;

// Widgets
const Widgets = () => <div className="widgets">Widgets</div>;

// Future Section
const Future = () => <div className="future">Future Development</div>;

// Notifications
const Notifications = () => <div className="notifications">Notifications</div>;

// Footer
const Footer = () => <div className="footer">Footer</div>;

export default function App() {
  return (
    <div className="layout">
      <Header />
      <Navigation />

      <div className="middle">
        <Sidebar />
        <MainContent />
        <Ads />
        <Widgets />
      </div>

      <div className="bottom">
        <Future />
        <Notifications />
      </div>

      <Footer />
    </div>
  );
}

