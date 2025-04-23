// script.js
const puzzleContainer = document.getElementById('puzzle-container');
const puzzleNumbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, '']; // Empty space for the sliding puzzle

// Function to create the puzzle
function createPuzzle() {
  puzzleContainer.innerHTML = ''; // Clear the container

  puzzleNumbers.forEach((number, index) => {
    const piece = document.createElement('div');
    piece.textContent = number;
    piece.classList.add('puzzle-piece');
    piece.setAttribute('data-index', index);

    piece.addEventListener('click', () => movePiece(index));
    
    puzzleContainer.appendChild(piece);
  });
}

// Function to move pieces
function movePiece(index) {
  // Find the index of the empty space
  const emptySpaceIndex = puzzleNumbers.indexOf('');

  // Check if the move is valid (only adjacent to the empty space)
  if (isValidMove(index, emptySpaceIndex)) {
    // Swap the piece with the empty space
    [puzzleNumbers[index], puzzleNumbers[emptySpaceIndex]] = [puzzleNumbers[emptySpaceIndex], puzzleNumbers[index]];
    createPuzzle(); // Re-render the puzzle
  }
}

// Function to check if the move is valid (adjacent to the empty space)
function isValidMove(index, emptySpaceIndex) {
  const validMoves = [
    emptySpaceIndex - 1, // left
    emptySpaceIndex + 1, // right
    emptySpaceIndex - 3, // up
    emptySpaceIndex + 3, // down
  ];

  return validMoves.includes(index) && Math.abs(emptySpaceIndex % 3 - index % 3) <= 1;
}

createPuzzle(); // Initialize the puzzle