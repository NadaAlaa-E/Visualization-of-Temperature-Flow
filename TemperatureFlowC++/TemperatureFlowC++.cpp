// TemperatureFlowC++.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"


// TemperatureFlowC++.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"


// TemperatureFlowC++.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <stdio.h>
#include<omp.h>
 struct _Point
{ 
public: 
	int X;
	int Y;
	_Point(){}
	_Point(int x, int y)
	{
		X = x;
		Y = y;
	}
};

enum CellType  { Block, HeatSource, ColdSource, NormalCell, Window };

 struct NormColor
{
	double r, g, b;
	NormColor(){}
	NormColor(double R,double G, double B)
	{
		r= R;
		g = G;
		b = B;
	}
};
class Cell
{
	public:
	float temperature; //scalar value 
	_Point position;
	CellType type;
	NormColor color;
	Cell()
	{}
	Cell(_Point position,CellType type,float temperature ,NormColor norm)
	{
		this->position = position;
		this->type = type;
		this->temperature = temperature;
		color = norm;
	}
	Cell(const Cell &Cell_)
	{
		this->position = Cell_.position;
		this->type = Cell_.type;
		this->temperature = Cell_.temperature;
		this->color = Cell_.color; 
	}
};

class add
{public:
int x , y;
add()
{
	x = 5;
	y = 6;
}
add(int X , int Y)
{
	x = X;
	y = Y;
}
int add1()
{
	return x+y;
}
};

bool IsValid(int x, int y, int N, int M)
	{
		return x >= 0 && x < N && y >= 0 && y < M;
	}
	Cell UpdateCell(Cell* grid, int i, int j, int N, int M)
	{
		int dirX[] = { 0, 0, 1, 1, 1, -1, -1, -1 };
		int dirY[] = { 1, -1, 0, 1, -1, 0, 1, -1 };
		Cell newCell =  Cell(grid[i*M+j]);

		int num_Neighbours = 1;
		if (grid[i*M+j].type == CellType::NormalCell)
		{
			for (int k = 0; k < 8; k++)
			{
				if (IsValid(i + dirX[k], j + dirY[k], N, M))
				{
					Cell neighbour = grid[((i + dirX[k])*M)+(j + dirY[k])];
					if (neighbour.type != CellType::Block)
					{
						newCell.temperature += neighbour.temperature;
						num_Neighbours++;
					}
				}
			}
		}
		newCell.temperature /= num_Neighbours;
		return newCell;
	}

	class CastGrid
	{
		Cell** mygrid;
	};


extern "C"  
{
	__declspec(dllexport)  Cell* CalculateFlow_ParallelMode_Cplus(Cell* grid,int N,int M, int n_threads)
	{
		Cell* newGrid = new Cell[N*M];//
 
		omp_set_num_threads(n_threads);
	#pragma omp parallel for shared(newGrid, grid, N, M)
        for (int i = 0; i < N*M; i++)
        {
            newGrid[i] = UpdateCell(grid, i/M, i%M, N, M);
        }		
		return newGrid;
	}


	__declspec(dllexport) Cell* return_new_cell(Cell* tmp)
	 {
		 return new Cell((*tmp));
	 }
	/*
	__declspec(dllexport) add* return_new_add()
	 {
		 return new add(8,9);
	 }
*/

	__declspec(dllexport) int subtract(int a,int b) 
	{
		return a-b;
	}
}




/*#include"TemperatureFlowC++.h"

namespace TemperatureFlow_Cpulse
{
double _TemperatureFlow::CalculateFlow_Parallel_Cpulse(double a, double b)
{
return a+b;
}
}

*/