function RightAd({ title, ads }) {
  return (
    <aside className="right-ad card-panel">
      <div className="section-tag">Advertisement</div>
      <h2>{title}</h2>
      <p className="muted-text">
        Keep the ad section visible but not distracting. It should support learning,
        not disturb the reading experience.
      </p>

      <div className="ad-stack">
        {ads.map((ad) => (
          <div className="ad-box" key={ad}>
            {ad}
          </div>
        ))}
      </div>
    </aside>
  );
}

export default RightAd;
