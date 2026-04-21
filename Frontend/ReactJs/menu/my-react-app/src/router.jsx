import { createBrowserRouter } from 'react-router-dom'
import AppLayout from './components/AppLayout'
import Home from './pages/Home'
// Import other pages as needed
// import About from './pages/About'
// import Contact from './pages/Contact'

const router = createBrowserRouter([
  {
    path: '/',
    element: <AppLayout />,
    children: [
      {
        index: true,
        element: <Home />,
      },
      // Add more routes here
      // {
      //   path: 'about',
      //   element: <About />,
      // },
      // {
      //   path: 'contact',
      //   element: <Contact />,
      // },
    ],
  },
])

export default router
