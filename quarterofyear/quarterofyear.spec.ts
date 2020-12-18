import { quarterOf } from "./quarterofyear";

describe("Basic tests", () => {
    it("Should pass basic tests", () => {
      expect(quarterOf(3)).toEqual(1);
      expect(quarterOf(8)).toEqual(3);
      expect(quarterOf(11)).toEqual(4);
    });
  });