Song History Logger
===================

Author: ipavl <https://www.github.com/ipavl/SongHistoryLogger>

This program uses the iTunes COM interface to display current song information and
optionally log it to an HTML file (songhistory.htm). This is useful if you want to
display this on a web server, in which case you would want to set the output folder
to be a web server's local path.

The idea for this came from thinking that if you're living with roommates and you're
playing music and they're curious as to what that cool song you just played (or played
25 minutes ago) was, you could easily just look it up in the file, or if it's on an
internal web server, they could just visit that page. It was more of a fun project and
an extension of my previous "iTunes Play Count Setter" application (although this was
written from scratch and is in C# instead of VB.NET), but that's the practical use case
I came up with. :P

Sample output screenshot (outdated): http://i.imgur.com/TPB7xoo.png
(Note to self: Japanese characters don't show up correctly.)

-- ipavl
	
Known Bugs
----------
* Closing and re-opening iTunes may cause the program to stop updating iTunes data, but
  restarting this application should fix it.
  
License
-------

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
