import { BrowserRouter, Route, Routes } from "react-router-dom";
import "./App.css";
import Home from "./sections/Home";

function App() {
  return (
    <BrowserRouter basename="/">
      <Routes>
        <Route path="/" element=<Home /> />
        <Route
          path="/game"
          element={
            <div className="flex justify-center items-center h-screen">
               <h1 className="bg-black text-white  pb-5 font-sans zoomAndFocus">
                Welcome to Trader Voyages UI
              </h1>
           </div>

          }
        />
      </Routes>
    </BrowserRouter>
  );
}

export default App;
