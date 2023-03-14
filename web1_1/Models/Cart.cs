using System;
using System.Collections.Generic;
using System.Linq;
using web1_1.DAL.Entities;

namespace web1_1.Models
{
    public class Cart
    {
        public Dictionary<int, CartItem> Items { get; set; }
        public Cart()
        {
            Items = new Dictionary<int, CartItem>();
        }

        public int Prices
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity * item.Value.Wheelchair1.Price);
            }
        }
        /// <summary>
        /// Количество объектов в корзине
        /// </summary>
        public int Count
        {
            get
            {
                return Items.Sum(item => item.Value.Quantity);
            }
        }
        /// <summary>
        /// Количество калорий
        /// </summary>
        
       
        public virtual void AddToCart(Wheelchair wheelchair)
        {

            // если объект есть в корзине
            // то увеличить количество

            if (Items.ContainsKey(wheelchair.WheelchairId))
                Items[wheelchair.WheelchairId].Quantity++;
            // иначе - добавить объект в корзину

            else
                Items.Add(wheelchair.WheelchairId, new CartItem
                {
                    Wheelchair1 = wheelchair,
                    Quantity = 1
                });
        }
        /// <summary>
        /// Удалить объект из корзины
        /// </summary>
        /// <param name="id">id удаляемого объекта</param>
        public virtual void RemoveFromCart(int id)

        {
            Items.Remove(id);
        }
        /// <summary>
        /// Очистить корзину
        /// </summary>
        public virtual void ClearAll()
        {
            Items.Clear();
        }
    }
    /// <summary>
    /// Клас описывает одну позицию в корзине
    /// </summary>
    public class CartItem
    {
        public Wheelchair Wheelchair1 { get; set; }
        public int Quantity { get; set; }

      
    }
}

