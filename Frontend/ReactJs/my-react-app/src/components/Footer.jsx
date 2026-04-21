import React from 'react'
import './Footer.css'

function Footer() {
  return (
    <footer className='footer'>
      <div className='footer-content'>
        <p>&copy; 2026 My React App. All rights reserved.</p>
        <div className='footer-links'>
          <a href='#'>Privacy</a>
          <a href='#'>Terms</a>
          <a href='#'>Contact</a>
        </div>
      </div>
    </footer>
  )
}

export default Footer
