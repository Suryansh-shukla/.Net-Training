import React from 'react'
import { Outlet } from 'react-router-dom'
import './MainLayout.css'

function MainLayout() {
  return (
    <main className='main-layout'>
      <div className='main-content'>
        <Outlet />
      </div>
    </main>
  )
}

export default MainLayout
