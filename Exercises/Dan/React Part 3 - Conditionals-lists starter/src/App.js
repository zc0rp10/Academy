import React from "react";
import "./App.css";
import MovieInfo from "./MovieInfo";
import movies from "./movies";

function App() {
    return (
        <div className="App">
            <header className="App-header">
                <h1>My Movies</h1>
            </header>
            <main>
                {movies.map((m) => {
                    return <MovieInfo key={m} movie={m} />;
                })}
            </main>
        </div>
    );
}

export default App;
