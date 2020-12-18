import { loadavg } from "os"

export const sumParts = (ls: number[]): number[] => {    
    return [...ls, 0].map((_, index) => {
        const subSet = ls.slice(index)
        const sum = subSet.reduce((prev, current) => prev + current, 0);
        return sum;
    });
}

export function partsSums(ls: number[]): number[] {
    var sumOfList: number[] = [];
    if(ls.length == 0){
        ls.push(0);
        return ls;
    }

    while (ls.length != 0) {
        let sum = ls.reduce((a, b) => a + b, 0);
        sumOfList.push(sum);
        ls.shift();

        if(ls.length == 0){
            sumOfList.push(0);
            return sumOfList;
        }
    }

    return sumOfList;
}