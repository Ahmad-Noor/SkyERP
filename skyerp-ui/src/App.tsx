import './App.css';
import { Layout } from './components/Home/Layout';
import { Home } from './components/Home/Home';
import './custom.css'

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <Home />
      </header>
    </div>
  );
}

export default App;
