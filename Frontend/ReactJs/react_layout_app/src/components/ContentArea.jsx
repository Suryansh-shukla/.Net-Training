function ContentArea() {
  return (
    <main className="content-area card-panel">
      <div className="section-tag">Center Content</div>
      <h2>Welcome to ItTechGenie</h2>
      <p>
        This center section is the most important area of the page. It should contain
        the tutorial explanation, code examples, diagrams, interview questions, MCQs,
        and project notes.
      </p>

      <div className="content-card-grid">
        <section className="mini-card">
          <h3>Why this layout is useful</h3>
          <ul>
            <li>Top area builds brand identity</li>
            <li>Left side helps with topic navigation</li>
            <li>Center area focuses on tutorial content</li>
            <li>Right side is perfect for ads or promotions</li>
          </ul>
        </section>

        <section className="mini-card">
          <h3>Suggested content in center area</h3>
          <ul>
            <li>Concept explanation</li>
            <li>Step-by-step examples</li>
            <li>Code snippets</li>
            <li>Interview questions and MCQs</li>
          </ul>
        </section>
      </div>

      <section className="mini-card code-preview">
        <h3>Suggested HTML structure</h3>
        <pre>{`<header>Top Menu</header>
<div class="main-layout">
  <aside>Left Menu</aside>
  <main>Center Content</main>
  <aside>Right Advertisement</aside>
</div>
<footer>Bottom Menu</footer>`}</pre>
      </section>
    </main>
  );
}

export default ContentArea;
