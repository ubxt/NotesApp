import './App.css';
import HomeView from './Views/HomeView';
import RegisterView from './Views/RegisterView';
import LoginView from './Views/LoginView';
import {BrowserRouter as Router, Switch, Route} from 'react-router-dom';
import NoteView from './Views/NoteView';

function App() {
  return (
    <Router>
      <div className="app">
        <Switch>
          <Route path="/home" exact component={HomeView} />
          <Route path="/notes/:id" component={NoteView} />
          <Route path="/signup" component={RegisterView}></Route>
          <Route path="/" component={LoginView}></Route>
        </Switch>
      </div>
    </Router>
  );
}

export default App;
