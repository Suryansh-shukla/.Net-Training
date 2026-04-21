import React from 'react'
import './Home.css'

function Home() {
  return (
    <div className='home-page'>
      <h1>Welcome Suryansh Shukla!</h1>
      <p>This is the main content area where pages will render using react-router-dom Outlet.</p>
      <div className='home-content'>
        <div className='card'>
          <h3>Feature 1</h3>
          <p>Description of your feature here.</p>
        </div>
        <div className='card'>
          <h3>Feature 2</h3>
          <p>Description of your feature here.</p>
        </div>
        <div className='card'>
          <h3>Feature 3</h3>
          <p>Description of your feature here.</p>
        </div>
      </div>
    </div>
  )
}

export default Home
