import { numPrimorial } from "./primorialofanumber";

describe("Basic tests", () => {
  it("Testing for 3", () => expect(numPrimorial(3)).toStrictEqual(30));
  it("Testing for 4", () => expect(numPrimorial(4)).toStrictEqual(210));
  it("Testing for 5", () => expect(numPrimorial(5)).toStrictEqual(2310));
  it("Testing for 8", () => expect(numPrimorial(8)).toStrictEqual(9699690));
  it("Testing for 9", () => expect(numPrimorial(9)).toStrictEqual(223092870));
});