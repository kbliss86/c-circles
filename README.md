# Circle Objects

## Objectives:
- Objects
- Methods
- Member Variables

## Task:
Calculate a circle’s diameter, circumference, and area. Additionally, allow the user to grow the circle (double its radius) and recalculate these values.

## What the Application Will Do:
1. The application prompts the user to enter a radius (accepts decimal values as `double`).
2. If invalid data is entered, the application displays an error and asks the user again for a radius.
3. Once valid data is entered, the application creates an instance of the `Circle` class and displays the circle's diameter, circumference, and area using methods.
4. The application then asks if the user wants the circle to grow (doubling the radius). If yes, the circle’s radius is doubled, and the diameter, circumference, and area are recalculated and displayed again.
5. If the user chooses not to grow the circle, the application displays a "goodbye" message along with the final radius of the circle.

## Build Specifications:
- **Circle Class**:
  - **Properties**:
    - `private double radius`
  - **Constructor**:
    - `public Circle(double radius)`
  - **Methods**:
    - `public double CalculateDiameter()`
    - `public double CalculateCircumference()`
    - `public double CalculateArea()`
    - `public void Grow()` (Doubles the radius)
    - `public double GetRadius()` (Returns the current radius)

- Use `System.Math.PI` for the value of pi.

## Hints:
- Ensure you use the correct formulas for diameter, circumference, and area of a circle:
  - Diameter = 2 × radius
  - Circumference = 2 × π × radius
  - Area = π × radius²

## Extra Challenges:
- Create a class named `Validator` with static methods to validate the radius input from the user.

## Example Console Preview:

Welcome to the Circle Tester Enter radius: 3 Diameter: 6 Circumference: 18.849... Area: 28.2743...

Should the circle grow? (y/n): y The circle is magically growing.

Diameter: 12 Circumference: 37.699... Area: 113.097...

Should the circle grow? (y/n): n Goodbye. The circle’s final radius is 6.