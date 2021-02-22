function enEtt(ord) {
    let ordLista = ["tidning", "falafel", "hipsteröl"];
    for (const item of ordLista) {
        if (item == ord) console.log("Yes");
        else console.log("No");
    }
}

enEtt("tidning");
