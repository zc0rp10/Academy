import React from "react";
import Favorited from "./Favorited";
import "./MovieInfo.css";
import RatingIndicator from "./RatingIndicator";

function MovieInfo({ movie }) {
    return (
        <div className="MovieInfo">
            <h2>
                {movie.title}
                <Favorited isFavorited={movie.favorite} />
            </h2>
            <p className="Description">{movie.description}</p>
            <p className="Rating">
                <RatingIndicator rating={movie.rating} />
            </p>
            <p className="Analysis">
                {movie.year < 2000 && movie.rating > 8.6 && "An old time classic!"}
            </p>
        </div>
    );
}

export default MovieInfo;
