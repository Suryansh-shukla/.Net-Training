import SimpleStateExample from "./components/SimpleStateExample";
import MediumStateExample from "./components/MediumStateExample";
import AdvancedStateExample from "./components/AdvancedStateExample";
import DataSharingExample from "./components/DataSharingExample";
import SendDataExample from "./components/SendDataExample";

export default function App() {
  return (
    <div className="page">
      <header className="hero">
        <p className="badge">React Tutorials</p>
        <h1>React State Tutorial Application</h1>
        <p className="subtitle">
          This sample project demonstrates simple, medium, and advanced uses of state,
          along with examples of how to send data from one component to another and how
          state can be shared across components using a parent component.
        </p>
      </header>

      <SimpleStateExample />
      <MediumStateExample />
      <AdvancedStateExample />
      <DataSharingExample />
      <SendDataExample />
    </div>
  );
}
