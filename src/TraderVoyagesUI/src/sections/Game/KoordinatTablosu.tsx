function KoordinatTablosu({ rows = 20, columns = 40 }) {
  const tabloVerileri = [];
  for (let y = 0; y < rows; y++) {
    const satir = [];
    for (let x = 0; x < columns; x++) {
      satir.push(`(${x}, ${y})`);
    }
    tabloVerileri.push(satir);
  }

  const satirlar = tabloVerileri.map((satir, rowIndex) => (
    <div key={rowIndex} style={{ marginBottom: "5px" }}>
      <tr>
        {satir.map((hucre, colIndex) => (
          <td key={colIndex}>{hucre}</td>
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
          <thead></thead>
          <div>
            <tbody>{satirlar}</tbody>
          </div>
        </table>
      </div>
    </>
  );
}

export default KoordinatTablosu;
