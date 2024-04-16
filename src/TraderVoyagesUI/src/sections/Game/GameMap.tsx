import React from "react";
import KoordinatTablosu from "./KoordinatTablosu";

const Game: React.FC = () => {
  return (
    <>
      <span>
        <img
          className="elephant"
          src="/src/assets/images/elephant-real.png"
        ></img>
      </span>
      <span>
        <img className="horse" src="/src/assets/images/horse-real.png"></img>
      </span>


      
      <div className="main">
        <KoordinatTablosu />
        <div className="heroDiv">
          {[...Array(20).keys()].map((index) => (
            <div className="innerDiv" key={index}>
              <span className="VerticalNumber pt-1" id="X"></span>
            </div>
          ))}
        </div>
        <div className="heroDiv2">
          {[...Array(40).keys()].map((index) => (
            <div className="outerDiv" id="Y" key={index}></div>
          ))}
        </div>
      </div>
    </>
  );
};

export default Game;
