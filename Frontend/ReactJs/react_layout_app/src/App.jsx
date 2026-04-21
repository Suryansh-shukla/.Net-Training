import TopMenu from './components/TopMenu';
import LeftMenu from './components/LeftMenu';
import ContentArea from './components/ContentArea';
import RightAd from './components/RightAd';
import Footer from './components/Footer';

function App() {
  const menuItems = [
    'Home',
    'HTML',
    'CSS',
    'JavaScript',
    'React',
    'Azure',
    'DevOps'
  ];

  const ads = [
    'Join our React Course',
    'Learn Azure with Real Projects',
    'Corporate Training Available',
    'Interview Question Banks'
  ];

  return (
    <div className="page-shell">
      <TopMenu companyName="ItTechGenie" />

      <div className="hero-banner">
        <h1>Tutorial Website Layout Demo</h1>
        <p>
          This React example shows a complete page structure with top menu,
          left navigation, center content, right-side advertisement panel, and footer.
        </p>
      </div>

      <div className="main-layout">
        <LeftMenu title="Tutorial Topics" items={menuItems} />
        <ContentArea />
        <RightAd title="ItTechGenie Advertisement" ads={ads} />
      </div>

      <Footer />
    </div>
  );
}

export default App;
