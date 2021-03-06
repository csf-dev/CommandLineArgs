//  
//  ParametersEnumeration.cs
//  
//  Author:
//       Craig Fowler <craig@craigfowler.me.uk>
// 
//  Copyright (c) 2011 Craig Fowler
// 
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
// 
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
// 
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System;

namespace CraigFowler.Cli.Mocks
{
  public enum ParametersEnumeration : int
  {
    [Parameter(Type = ParameterType.ValueRequired, ValueType = typeof(string))]
    [ParameterLongNames("action")]
    [ParameterShortNames("A")]
    Action,
    
    [Parameter(Type = ParameterType.NoValue)]
    [ParameterLongNames("verbose")]
    [ParameterShortNames("v")]
    Verbose,
    
    [Parameter(Type = ParameterType.NoValue)]
    [ParameterLongNames("help")]
    [ParameterShortNames("h")]
    Help,
    
    [Parameter(Type = ParameterType.ValueOptional, ValueType = typeof(int))]
    [ParameterLongNames("count")]
    Count,
    
    [Parameter(Type = ParameterType.ValueOptional, ValueType = typeof(bool))]
    [ParameterLongNames("explode")]
    Explode
  }
}

