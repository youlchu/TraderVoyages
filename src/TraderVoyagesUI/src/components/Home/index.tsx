import React from "react";

const Home: React.FC = () => {
  return (
    <div className="flex justify-center items-center h-screen">
      <div className="w-1/2 flex justify-center items-center h-full border-dotted border-r-2 border-gray-900">
        Player 1
      </div>
      <div className="w-1/2 flex justify-center items-center h-full">
        Player 2
      </div>
    </div>
  );
};

export default Home;
