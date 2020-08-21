import turtle

t = turtle.Turtle()
t.speed(10)
t.penup()
t.setpos(0,-100)
t.pendown()

def DrawSymbol(c1, c2, distance, angle):
    t.color(c1,c2)
    t.begin_fill()
    t.forward(distance)
    t.left(angle)
    t.forward(distance)
    t.left(angle)
    t.end_fill()

    if(distance > 0):
        distance = distance - 7
        if(distance % 2 == 0):
            DrawSymbol(c2, c1, distance, angle)
        else:
            DrawSymbol(c1, c2, distance, angle)

DrawSymbol('green','white',600, 130)
