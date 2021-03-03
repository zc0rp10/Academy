import React from "react";

export default function RatingIndicator({ rating }) {
    if (rating > 8.6)
        return (
            <span role="img" aria-label="Bad Rating">
                👍
            </span>
        );
    else
        return (
            <span role="img" aria-label="Good Rating">
                👎
            </span>
        );
}
