import React from "react";

export default function Favorited({ isFavorited }) {
    if (isFavorited)
        return (
            <span className="Star" role="img" aria-label="Favorite">
                ⭐
            </span>
        );
    else return <span></span>;
}
