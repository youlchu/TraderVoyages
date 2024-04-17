import React from "react";
import KoordinatTablosu from "./KoordinatTablosu";
import { useState } from "react";

const Game: React.FC = () => {
  const [top, setTop] = useState(20);
  const [left, setLeft] = useState(985);

  const loverClick = () => {
    console.log('');
    setTop(top + 31);
  };
  const upperClick = () => {
    console.log({top});
    setTop(top - 31);
  };const rightClick = () => {
    console.log('');
    setLeft(left + 31);
  };
  const leftClick = () => {
    console.log();
    setLeft(left - 31);
  };
  
  return (
    <>
    <div className="buttons-for">
    <button className="bg-white border " id="lower" onClick={loverClick}>lower</button>
    <button className="bg-white border " id="upper" onClick={upperClick}>upper</button>
    </div>
    <br/>
    <div className="buttons-for">
    <button className="bg-white border " id="right" onClick={rightClick}>right</button>
    <button className="bg-white border " id="left" onClick={leftClick}>left</button>
    </div>
      <span>
        <img
          className="elephant"
          style={{ position: 'relative', top: `${top}px`, left: `${left}px` }}
          src="/src/assets/images/elephant-real.png"
        ></img>
      </span>
      <span>
        <img className="horse" src="/src/assets/images/horse-real.png"></img>
      </span>
      <span>
        <img className="castle" src="/src/assets/images/castle.png"></img>
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
