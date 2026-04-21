import React from 'react'
import Topbar from './Topbar'
import Sidebar from './Sidebar'
import MainLayout from './MainLayout'
import Footer from './Footer'
import './AppLayout.css'

function AppLayout() {
  return (
    <div className='app-layout'>
      <Topbar />
      <div className='layout-container'>
        <Sidebar />
        <MainLayout />
      </div>
      <Footer />
    </div>
  )
}

export default AppLayout
