import React from "react";
import GameMap from "./GameMap";

const Game: React.FC = () => {
  // const [top, setTop] = useState(20);
  // const [left, setLeft] = useState(985);

  // const loverClick = () => {
  //   console.log("");
  //   setTop(top + 31);
  // };
  // const upperClick = () => {
  //   console.log({ top });
  //   setTop(top - 31);
  // };
  // const rightClick = () => {
  //   console.log("");
  //   setLeft(left + 31);
  // };
  // const leftClick = () => {
  //   console.log();
  //   setLeft(left - 31);
  // };

  return (
    <div className="bg-black  h-screen ">
      {/* <div className="buttons-for">
        <button className="bg-white border " id="lower" onClick={loverClick}>
          lower
        </button>
        <button className="bg-white border " id="upper" onClick={upperClick}>
          upper
        </button>
      </div>
      <br />
      <div className="buttons-for">
        <button className="bg-white border " id="right" onClick={rightClick}>
          right
        </button>
        <button className="bg-white border " id="left" onClick={leftClick}>
          left
        </button>
      </div> */}

      <div className="main">
        <GameMap />
      </div>
    </div>
  );
};

export default Game;
