import { useEffect, useState } from "react";

function App() {
  const [tickets, setTickets] = useState<any[]>([]);

  useEffect(() => {
    fetch("https://localhost:5001/api/tickets/USER_GUID")
      .then(res => res.json())
      .then(data => setTickets(data));
  }, []);

  return (
    <div>
      <h1>Venta de Entradas - Racing Club</h1>
      {tickets.map(t => (
        <div key={t.id}>
          Sector: {t.sectorName}
        </div>
      ))}
    </div>
  );
}

export default App;