import React from 'react'
import './Topbar.css'

function Topbar() {
  return (
    <div className='topbar'>
      <div className='topbar-content'>
        <h1>Logo/App Name</h1>
        <nav className='topbar-nav'>
          <a href='#'>Home</a>
          <a href='#'>About</a>
          <a href='#'>Contact</a>
        </nav>
      </div>
    </div>
  )
}

export default Topbar
