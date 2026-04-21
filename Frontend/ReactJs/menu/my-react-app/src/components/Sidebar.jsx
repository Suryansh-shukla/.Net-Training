import React from 'react'
import './Sidebar.css'

function Sidebar({ title = 'Menu', items = [] }) {
  return (
    <aside className='sidebar card-panel'>
      <div className='sidebar-content'>
        <h3>{title}</h3>
        <ul className='sidebar-menu'>
          <li><a href='#'>Dashboard</a></li>
          <li><a href='#'>Profile</a></li>
          <li><a href='#'>Settings</a></li>
          <li><a href='#'>Logout</a></li>
        </ul>
        <ul className='menu-list'>
          {items.map((item) => (
            <li key={item}>
              <a href='#'>{item}</a>
            </li>
          ))}
        </ul>
      </div>
    </aside>
  )
}

export default Sidebar
