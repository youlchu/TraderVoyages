import React from "react";
import GameMap from "./GameMap";
import KoordinatTablosu from "./KoordinatTablosu";

const Game: React.FC = () => {
  return (
    <div className="bg-black  h-screen ">
      <GameMap />
    </div>
  );
};

export default Game;
