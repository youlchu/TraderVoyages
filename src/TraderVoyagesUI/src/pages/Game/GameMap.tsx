function GameMap({ rows = 18, columns = 60 }) {
  const tabloVerileri = [];
  for (let y = 0; y < rows; y++) {
    const satir = [];
    for (let x = 0; x < columns; x++) {
      satir.push(`(${x}, ${y})`);
    }
    tabloVerileri.push(satir);
  }

  const satirlar = tabloVerileri.map((satir, rowIndex) => (
    <div
      key={rowIndex}
      style={{
        marginBottom: "5px",
        color: "red",
      }}
    >
      <tr>
        {satir.map((hucre, colIndex) => (
          <td key={colIndex}>
            <img
              src="/src/assets/images/horse-real.png"
              alt={hucre}
              style={{
                width: "30px",
                height: "30px",
                position: "absolute",
                top: "0px",
                left: "0px",
              }}
            />
            resim
          </td>
        ))}
      </tr>
    </div>
  ));

  const kolonBasliklar = [];
  for (let i = 0; i < columns; i++) {
    kolonBasliklar.push(<th key={i}>Col {i}</th>);
  }

  return (
    <>
      <div>
        <table id="colnum">
          <div>
            <tbody>{satirlar}</tbody>
          </div>
        </table>
      </div>
    </>
  );
}

export default GameMap;
