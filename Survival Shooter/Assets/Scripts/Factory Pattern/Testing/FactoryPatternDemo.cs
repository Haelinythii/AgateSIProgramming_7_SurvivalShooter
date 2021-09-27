using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryPatternDemo : MonoBehaviour
{
    private void Start()
    {
        ShapeFactory shapeFactory = new ShapeFactory();

        Shape shape1 = shapeFactory.GetShape("CIRCLE");
        shape1.Draw();

        Shape shape2 = shapeFactory.GetShape("RECTANGLE");
        shape2.Draw();

        Shape shape3 = shapeFactory.GetShape("SQUARE");
        shape3.Draw();
    }
}
