import React from 'react';

const Game: React.FC = () => {
    return (
        <>
        <div className='main'>
         <div className="heroDiv">
          {[...Array(20).keys()].map((index) => (
            <div className="innerDiv" key={index}>
              <span className='VerticalNumber pt-1' id='X'></span>
            </div>
          ))}
        </div>
        <div className="heroDiv2">
          {[...Array(40).keys()].map((index) => (
            <div className="outerDiv" id='Y' key={index}></div>
          ))}
         </div>
        </div>
      </>
        );
    }

export default Game;