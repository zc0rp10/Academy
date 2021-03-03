import React from "react";

export default function CoolnessIndicator(props) {
    if (props.isCool) {
        return <span className="cool">Cool</span>;
    }
    return <span className="not_cool">Not cool man..</span>;
}
