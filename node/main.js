'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', (inputStdin) => {
  inputString += inputStdin;
});

process.stdin.on('end', (_) => {
  inputString = inputString
    .trim()
    .split('\n')
    .map((string) => {
      return string.trim();
    });

  main();
});

function readline() {
  return inputString[currentLine++];
}

function main() {
  let test = Number(readline());
  while (test--) {
    let len = Number(readline()) - 1;
    let info = { 1: 0, 2: 0 };
    let input = readline();
    input.split(' ').map((el) => {
      info[el] += Number(el);
    });
    if (!(info[1] & 1) && !(info[2] & 1)) {
      console.log('YES');
    } else if (info[1] & 1) {

    }
  }
}
