My task was to model a Restaurant:

In a Restaurant different kinds of people can exist at the same time: Chefs, Waiters and Guests.
All people who are inside a Restaurant have a name and can be identified uniquely by an ID number.
All of them can interact with each other, but a bit differently:
- Chefs can interact only with Waiters - a Chef takes all Orders available at a Waiter.
- Waiters can interact with Guests - a Waiter takes a single Order from a Guest and stores it.

I can not other interactions - when this happens I have to make sure this doesn’t go unnoticed.
Guests have a preference - they always order the same thing (when a Guest interacts with a Waiter, he/she always will order the same thing, no matter what).
From now on, Waiters should keep track of who ordered what (every Guest can order one thing).
Chefs when taking orders from the Waiters must keep track of which order will be made for which Guest.
