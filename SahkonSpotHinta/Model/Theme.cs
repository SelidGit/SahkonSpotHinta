﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SahkonSpotHinta.Model;

public sealed class Theme
{
	public static readonly Theme Dark = new(AppTheme.Dark, "Night Mode");
	public static readonly Theme Light = new(AppTheme.Light, "Day Mode");
	public static readonly Theme System = new(AppTheme.Unspecified, "Follow System");

	public static List<Theme> AvailableThemes { get; } = new()
{
	Dark,
	Light,
	System
};

	public AppTheme AppTheme { get; }
	public string DisplayName { get; }

	private Theme(AppTheme theme, string displayName)
	{
		AppTheme = theme;
		DisplayName = displayName;
	}

	public static Theme Get(AppTheme theme)
	{
		return theme switch
		{
			AppTheme.Dark => Dark,
			AppTheme.Light => Light,
			AppTheme.Unspecified => System,
			_ => throw new ArgumentOutOfRangeException(nameof(theme), theme, null)
		};
	}
}
