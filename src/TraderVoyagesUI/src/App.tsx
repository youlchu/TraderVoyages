import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./App.css";
import Home from "./sections/Home";
import Game from "./sections/Game";

function App() {
  return (
    <BrowserRouter basename="/">
      <Routes>
        <Route path="/" element=<Home /> />
        <Route
          path="/game"
          element=<Game />
        />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
