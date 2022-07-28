﻿using BookReservation.Shared.Dtos;
using BookReservation.Shared.Enums;

namespace BookReservation.Client.TodoData
{
    public static class TodoCacheData
    {
        public static List<Todo> TodoList()
        {
            return new List<Todo>
            {
                new Todo{Id = 1, Title = "Test 1", Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",Statu=TaskStatu.Todo},
                new Todo{Id = 2, Title = "Test 2", Description = "when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged.",Statu=TaskStatu.Completed},
                new Todo{Id = 1, Title = "Test 3", Description = "t was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",Statu=TaskStatu.Completed},
                new Todo{Id = 1, Title = "Test 4", Description = "It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. The point of using Lorem Ipsum is that it has a more-or-less normal distribution of letters, as opposed to using",Statu=TaskStatu.Todo},
                new Todo{Id = 1, Title = "Test 5", Description = "nglish. Many desktop publishing packages and web page editors now use Lorem Ipsum as their default model text, and a search for 'lorem ipsum' will uncover many web sites still in their infancy.",Statu=TaskStatu.Completed},
            };
        }
    }
}
