const suits = ['Hearts', 'Diamonds', 'Clubs', 'Spades'];
const values = ['2', '3', '4', '5', '6', '7', '8', '9', '10', 'J', 'Q', 'K', 'A'];

let deck = [];

function createDeck() {
    deck = [];
    for (let suit of suits) {
        for (let value of values) {
            deck.push({ suit, value });
        }
    }
}

function shuffleDeck() {
    for (let i = deck.length - 1; i > 0; i--) {
        const j = Math.floor(Math.random() * (i + 1));
        [deck[i], deck[j]] = [deck[j], deck[i]];
    }
}

function dealCards() {
    createDeck();
    shuffleDeck();

    const player1Hand = document.getElementById('player1-hand');
    const player2Hand = document.getElementById('player2-hand');

    player1Hand.innerHTML = '';
    player2Hand.innerHTML = '';

    for (let i = 0; i < 5; i++) {
        const card1 = document.createElement('div');
        card1.className = 'card';
        card1.textContent = `${deck[i].value} of ${deck[i].suit}`;
        player1Hand.appendChild(card1);

        const card2 = document.createElement('div');
        card2.className = 'card';
        card2.textContent = `${deck[i + 5].value} of ${deck[i + 5].suit}`;
        player2Hand.appendChild(card2);
    }
}