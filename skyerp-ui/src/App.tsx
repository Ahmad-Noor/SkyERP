import BackOffice from './components/BackOffice';

// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <BackOffice />
//       </header>
//     </div>
//   );
// }

// export default App;
import {
  BrowserRouter as Router,
  Switch,
  Route,
  Link
} from "react-router-dom";

import Users from './components/pages/SignIn'
import About from './components/pages/Album'

export default function App() {
  return (
    <Router>


      {/* A <Switch> looks through its children <Route>s and
            renders the first one that matches the current URL. */}
      <Switch>
        <Route path="/about">
          <About />
        </Route>
        <Route path="/users">
          <Users />
        </Route>
        <Route path="/">
          <BackOffice />
        </Route>
      </Switch>

    </Router>
  );
}