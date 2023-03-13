import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import Header from "./components/Header";
import Footer from "./components/Footer";
import Disclaimer from "./pages/Disclaimer";
import Home from "./pages/Home";
import NotFound from "./pages/NotFound";
import Position from "./pages/Position";
import Positions from "./pages/Positions";
import Team from "./pages/Team";
import Teams from "./pages/Teams";

function App() {
  return (
    <div className="App">
      <Router>
        <Header />
        <Routes>
          <Route path="/" element={<Home />}/>
          <Route path="/positions" element={<Positions />}/>
          <Route path="/positions/:player_position" element={<Position />}/>
          <Route path="/teams" element={<Teams />}/>
          <Route path="/teams/:id" element={<Team />}/>
          <Route path="/disclaimer" element={<Disclaimer />}/>
          <Route path="/*" element={<NotFound />}/>
        </Routes>
        <Footer />
      </Router>
    </div>
  );
}

export default App;
