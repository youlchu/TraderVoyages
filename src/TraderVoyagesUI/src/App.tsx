import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./App.css";
import Home from "./components/Home";

function App() {
  return (
    <BrowserRouter basename="/">
      <Routes>
        <Route path="/" element=<Home /> />
        <Route
          path="/game"
          element={
            <h1 className="min-h-screen bg-black text-white font-sans">
              Welcome to Trader Voyages UI
            </h1>
          }
        />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
