
        void star_pos_spiral_coordinate(int start_x, int start_y, int size_of_spiral, int step_for_coordinate)
        {
            var move_direction = 1;
            List<string> ls_of_coordinates = new List<string>();
            var side_size_start = 1;
            var ammount_of_values = 1;
            var step = step_for_coordinate;
            for (var how_many_sides = 0; how_many_sides < size_of_spiral; how_many_sides++)
            {


                for (var i = side_size_start; i <= 2; i++)
                {

                    //Console.WriteLine($"{ammount_of_values}");
                    if (move_direction > 4)
                    {
                        move_direction = 1;
                    }



                    //we add values to list
                    for (var a = 1; a <= ammount_of_values; a++)
                    {
                        //if we working with left and up movenets
                        if (ammount_of_values % 2 != 0)
                        {
                            //direction 1
                            if (move_direction == 1)
                            {
                                //Console.WriteLine($"move_direction 1");
                                for (var z = 1; z <= ammount_of_values; z++)
                                {
                                    start_x -= step;
                                    // x - 5 
                                    ls_of_coordinates.Add($"{start_x} {start_y}");
                                    Console.WriteLine($"{start_x} {start_y}");
                                }
                                move_direction += 1;
                            }
                            //direction 2
                            if (move_direction == 2)
                            {
                                //Console.WriteLine($"move_direction 2");
                                for (var z = 1; z <= ammount_of_values; z++)
                                {
                                    start_y += step;
                                    //y + 5
                                    ls_of_coordinates.Add($"{start_x} {start_y}");
                                    Console.WriteLine($"{start_x} {start_y}");
                                }
                                move_direction += 1;
                            }


                        }
                        //else we work with right movements
                        else
                        {
                            //direction 3
                            if (move_direction == 3)
                            {
                                //Console.WriteLine($"move_direction 3");
                                for (var z = 1; z <= ammount_of_values; z++)
                                {
                                    start_x += step;
                                    //x + 5
                                    ls_of_coordinates.Add($"{start_x} {start_y}");
                                    Console.WriteLine($"{start_x} {start_y}");
                                }
                                move_direction += 1;
                            }

                            //direction 4
                            if (move_direction == 4)
                            {
                                //Console.WriteLine($"move_direction 4");
                                for (var z = 1; z <= ammount_of_values; z++)
                                {
                                    start_y -= step;
                                    //y - 5
                                    ls_of_coordinates.Add($"{start_x} {start_y}");
                                    Console.WriteLine($"{start_x} {start_y}");
                                }
                                move_direction += 1;
                            }
                        }

                    }
                    //change direction 

                }


                ammount_of_values += 1;

            }


            //show all dots 
            // foreach(var dot_pair in ls_of_coordinates)
            // {
            //     Console.WriteLine(dot_pair);
            // }

        }

        star_pos_spiral_coordinate(0, 0,150,1);
