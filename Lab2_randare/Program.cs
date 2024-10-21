﻿using System;
using OpenTK;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

class InteractiveWindow : GameWindow
{
    private float _x = 0.0f;
    private float _y = 0.0f;

    public InteractiveWindow()
        : base(800, 600, GraphicsMode.Default, "OpenTK Interactive Example")
    {
    }

    protected override void OnLoad(EventArgs e)
    {
        base.OnLoad(e);
        GL.ClearColor(0.39f, 0.58f, 0.93f, 1.0f); 
    }

    protected override void OnUpdateFrame(FrameEventArgs e)
    {
        base.OnUpdateFrame(e);

        // Control prin tastele W, A, S, D pentru a muta triunghiul
        if (Keyboard.GetState().IsKeyDown(Key.W))
            _y += 0.05f;
        if (Keyboard.GetState().IsKeyDown(Key.S))
            _y -= 0.05f;

        if (Keyboard.GetState().IsKeyDown(Key.A))
            _x -= 0.05f;
        if (Keyboard.GetState().IsKeyDown(Key.D))
            _x += 0.05f;
    }

    protected override void OnMouseMove(MouseMoveEventArgs e)
    {
        base.OnMouseMove(e);

        _x = (e.X - Width / 2) / (Width / 2.0f);
        _y = -(e.Y - Height / 2) / (Height / 2.0f);
    }

    protected override void OnRenderFrame(FrameEventArgs e)
    {
        base.OnRenderFrame(e);

        GL.Clear(ClearBufferMask.ColorBufferBit);

        GL.Begin(PrimitiveType.Triangles);

        GL.Color3(1.0f, 0.0f, 0.0f); // Roșu

        // Definim vârfurile triunghiului în funcție de poziția curentă (_x, _y)
        GL.Vertex2(_x, _y + 0.05f);    // Vârful de sus
        GL.Vertex2(_x - 0.05f, _y - 0.05f);  // Vârful din stânga jos
        GL.Vertex2(_x + 0.05f, _y - 0.05f);  // Vârful din dreapta jos

        GL.End();

        SwapBuffers();
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);

        GL.Viewport(0, 0, Width, Height);
        GL.MatrixMode(MatrixMode.Projection);
        GL.LoadIdentity();
        GL.Ortho(-1.0, 1.0, -1.0, 1.0, -1.0, 1.0); 
        GL.MatrixMode(MatrixMode.Modelview);
    }

    protected override void OnKeyDown(KeyboardKeyEventArgs e)
    {
        base.OnKeyDown(e);

        if (e.Key == Key.Escape)
            this.Close();
    }

    static void Main(string[] args)
    {
        using (InteractiveWindow window = new InteractiveWindow())
        {
            window.Run(60.0);  
        }
    }
}