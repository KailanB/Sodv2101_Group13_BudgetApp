
USE Sodv2101_BudgetAppDB
GO


INSERT INTO IncomeType (Type) VALUES
('Salary'),
('Hourly');

/*
('Freelance'),
('Rental Income'),
('Investment Returns'),
('Side Hustle'),
('Government Benefits'),
('Other') ;
*/




INSERT INTO Users (FirstName, LastName, Email, Password) VALUES
('Alex', 'Fincher', 'alex.fincher@example.com', 'Pass1234'),
('Taylor', 'Rivers', 'taylor.rivers@example.com', 'SecurePass!'),
('Jordan', 'Harper', 'jordan.harper@example.com', 'BudgetMaster2024'),
('Charlie', 'Dale', 'charlie.dale@example.com', 'SavingsPro2024'),
('Sam', 'Rowe', 'sam.rowe@example.com', 'FinanceGuru2024');




INSERT INTO Income (Amount, TimePeriod, IncomeTypeID, UserID) VALUES
(7500, 'Monthly', 1, 1),  -- Regular salary  - Alex, Salary
(25, 'Bi-Weekly', 2, 1), -- Hourly job
(15, 'Weekly', 2, 1), 
(1500.00, 'Weekly', 2, 2), -- Taylor, Hourly
(2500.00, 'Monthly', 2, 3), -- Jordan, Hourly
(200.00, 'Quarterly', 2, 4), -- Charlie, Salary
(300.00, 'Weekly', 1, 5); -- Sam, Hourly 

INSERT INTO HoursWorked ([Hours], Date, IncomeID) VALUES
(30, '2024-10-14', 2),  -- Hourly job, October
(25, '2024-10-31', 2), 

(35, '2024-11-15', 2),  -- Hourly job, November
(25, '2024-11-29', 2), 

(35, '2024-12-15', 2),  -- Hourly job, December
(35, '2024-12-30', 2),


(10, '2024-10-14', 3),  -- Hourly job, October
(10, '2024-10-31', 3), 

(10, '2024-11-15', 3),  -- Hourly job, November
(10, '2024-11-29', 3), 

(10, '2024-12-15', 3),  -- Hourly job, December
(10, '2024-12-30', 3),


(25.00, '2024-11-16', 5),
(15.75, '2024-11-17', 3);

INSERT INTO Budget (BudgetName, MaxAmount, Description, UserID) VALUES
('Groceries', 600, 'Monthly food supplies.', 1),
('Essentials', 1200, 'Rent and utilities.', 1),
('Eating Out', 300, 'Dining out and takeout.', 1),
('Entertainment', 200, 'Movies, games, and subscriptions.', 1),
('Fitness', 150, 'Gym and sports activities.', 1), -- Alex

('Essentials', 500.00, 'Tools and services for projects', 2), -- Taylor
('Fitness', 1500.00, 'Repairs and upkeep for rental property', 3), -- Jordan
('Entertainment', 300.00, 'Money for reinvestment opportunities', 4), -- Charlie
('Other', 1000.00, 'Emergency fund and long-term savings', 5); -- Sam


INSERT INTO FinancialGoal (Amount, Description, Deadline, UserID) VALUES
(2000, 'Emergency Fund.', '2025-03-31', 1),
(8000, 'Buy a reliable used car.', '2025-12-31', 1),
(25000, 'Save for a house down payment.', '2026-12-31', 1), -- Alex


(5000.00, 'Pay off student loans', '2025-01-15', 2), -- Taylor
(15000.00, 'Invest in a second property', '2025-12-31', 3), -- Jordan
(2000.00, 'Save for a vacation', '2025-03-15', 4), -- Charlie
(3000.00, 'Build an emergency fund', '2025-09-01', 5); -- Sam

INSERT INTO Contribution (GoalID, Amount, Description) VALUES
(1, 500, 'First deposit for emergency fund.'),  -- Alex
(1, 300, 'Freelance earnings added.'),
(1, 200, 'Savings from reduced expenses.'),

(2, 1000, 'Year-end bonus added for car fund.'),
(2, 500, 'Monthly savings contribution.'),
(2, 300, 'Cutting down on entertainment expenses.'),

(3, 2000, 'Saved from reduced rent costs.'),
(3, 1500, 'Freelance job contributions.'),
(3, 3000, 'Salary increment savings.'),  -- Alex


(4, 1000.00, 'Paid extra from freelance gig'), -- Taylor
(5, 5000.00, 'Initial savings for property'), -- Jordan
(6, 500.00, 'Set aside from investments'), -- Charlie
(7, 1000.00, 'First emergency fund deposit'); -- Sam



INSERT INTO Expense(BudgetID, Amount, Description, PurchaseDate) VALUES 

---- GROCERIES FOR ALEX
-- October
(1, 'grocery', 20, 'Quick pickup of snacks.', '2024-10-02'),
(1, 'grocery', 250, 'Monthly stock-up of essentials.', '2024-10-05'),
(1, 'grocery', 80, 'Mid-month vegetables and fruits.', '2024-10-15'),
(1, 'grocery', 150, 'Prepping for a dinner party.', '2024-10-22'),
(1, 'grocery', 90, 'End-of-month top-up.', '2024-10-30'),

-- November
(1, 'grocery', 30, 'Milk and bread.', '2024-11-03'),
(1, 'grocery', 240, 'Monthly stock-up.', '2024-11-07'),
(1, 'grocery', 120, 'Holiday baking supplies.', '2024-11-20'),
(1, 'grocery', 110, 'Extra snacks for visitors.', '2024-11-25'),
(1, 'grocery', 90, 'Weekend dinner groceries.', '2024-11-28'),

-- December
(1, 'grocery', 50, 'Holiday treats.', '2024-12-05'),
(1, 'grocery', 300, 'Monthly stock-up for holidays.', '2024-12-07'),
(1, 'grocery', 100, 'Party supplies.', '2024-12-15'),
(1, 'grocery', 80, 'Special occasion ingredients.', '2024-12-20'),
(1, 'grocery', 70, 'End-of-year groceries.', '2024-12-30'),


-- ESSENTIALS FOR ALEX
-- October
(2, 'grocery', 800, 'Monthly rent.', '2024-10-01'),
(2, 'grocery', 120, 'Utility bills.', '2024-10-05'),
(2, 'grocery', 50, 'Water bill.', '2024-10-10'),
(2, 'grocery', 30, 'Phone recharge.', '2024-10-20'),

-- November
(2, 'grocery', 800, 'Monthly rent.', '2024-11-01'),
(2, 'grocery', 140, 'Utility bills.', '2024-11-06'),
(2, 'grocery', 20, 'Repair supplies.', '2024-11-10'),
(2, 'grocery', 40, 'Cleaning services.', '2024-11-20'),

-- December
(2, 'grocery', 800, 'Monthly rent.', '2024-12-01'),
(2, 'grocery', 130, 'Utility bills.', '2024-12-10'),
(2, 'grocery', 20, 'Emergency plumbing.', '2024-12-18'),
(2, 'grocery', 120, 'End-of-year maintenance.', '2024-12-28'),


-- EATING OUT FOR ALEX
-- October
(3, 'grocery', 40, 'Coffee date.', '2024-10-05'),
(3, 'grocery', 80, 'Lunch with colleagues.', '2024-10-12'),
(3, 'grocery', 50, 'Weekend dinner.', '2024-10-20'),
(3, 'grocery', 100, 'Takeout for a party.', '2024-10-28'),

-- November
(3, 'grocery', 30, 'Breakfast outing.', '2024-11-03'),
(3, 'grocery', 70, 'Lunch with family.', '2024-11-10'),
(3, 'grocery', 100, 'Dinner date.', '2024-11-18'),
(3, 'grocery', 90, 'Late-night takeout.', '2024-11-26'),

-- December
(3, 'grocery', 60, 'Holiday brunch.', '2024-12-08'),
(3, 'grocery', 100, 'Dinner with visiting relatives.', '2024-12-15'),
(3, 'grocery', 80, 'End-of-year celebration dinner.', '2024-12-30'),

-- ENTERTAINMENT FOR ALEX
-- October
(4, 'grocery', 50, 'Netflix subscription.', '2024-10-01'),
(4, 'grocery', 60, 'Concert tickets.', '2024-10-10'),
(4, 'grocery', 50, 'Movie night.', '2024-10-25'),

-- November
(4, 'grocery', 50, 'Netflix subscription.', '2024-11-01'),
(4, 'grocery', 80, 'Theater play tickets.', '2024-11-14'),
(4, 'grocery', 60, 'Escape room game.', '2024-11-27'),

-- December
(4, 'grocery', 50, 'Netflix subscription.', '2024-12-01'),
(4, 'grocery', 70, 'Amusement park visit.', '2024-12-18'),
(4, 'grocery', 60, 'End-of-year concert.', '2024-12-30'),


-- FITNESS FOR ALEX
-- October
(5, 'grocery', 50, 'Gym membership.', '2024-10-01'),
(5, 'grocery', 30, 'New workout gear.', '2024-10-15'),
(5, 'grocery', 40, 'Yoga class subscription.', '2024-10-25'),

-- November
(5, 'grocery', 50, 'Gym membership.', '2024-11-01'),
(5, 'grocery', 40, 'Fitness app subscription.', '2024-11-14'),
(5, 'grocery', 50, 'New running shoes.', '2024-11-21'),

-- December
(5, 'grocery', 50, 'Gym membership.', '2024-12-01'),
(5, 'grocery', 30, 'Holiday workout gear.', '2024-12-12'),
(5, 'grocery', 40, 'New yoga mat.', '2024-12-28'),


(8, 'grocery', 150.00, 'Concert Tickets', '2024-11-03'),
(7, 'grocery', 200.00, 'Monthly Gym Membership', '2024-11-04'),
(6, 'grocery', 30.00, 'Gas for Car', '2024-11-05'),
(6, 'grocery', 1200.00, 'Monthly Rent', '2024-11-01'),
(6, 'grocery', 60.00, 'Utilities - Electricity Bill', '2024-11-03'),
(9, 'grocery', 25.00, 'Birthday Gift for Friend', '2024-11-06'),
(8, 'grocery', 8.00, 'Lunch at Work', '2024-11-07'),
(8, 'grocery', 10.00, 'Streaming Service Subscription', '2024-11-08');



