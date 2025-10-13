#include <cstdio>      // for printf, scanf
#include <stdexcept>   // for exception handling
using namespace std;

class Date {
private:
    int day, month, year;

    // Check if year is leap year
    bool isLeapYear(int y) {
        return (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0);
    }

    // Validate date
    bool isValidDate(int d, int m, int y) {
        if (y < 1 || m < 1 || m > 12 || d < 1)
            return false;

        int daysInMonth[] = {31,28,31,30,31,30,31,31,30,31,30,31};
        if (isLeapYear(y))
            daysInMonth[1] = 29;

        if (d > daysInMonth[m - 1])
            return false;

        return true;
    }

public:
    // Default constructor
    Date() {
        day = 1;
        month = 1;
        year = 2000;
    }

    // Parameterized constructor with validation
    Date(int d, int m, int y) {
        if (!isValidDate(d, m, y))
            throw invalid_argument("Invalid date entered!");
        day = d;
        month = m;
        year = y;
    }

    // Function to print date
    void printDate() const {
        printf("%02d/%02d/%04d\n", day, month, year);
    }

    // Operator < overloading
    bool operator<(const Date& other) const {
        if (year < other.year)
            return true;
        else if (year == other.year && month < other.month)
            return true;
        else if (year == other.year && month == other.month && day < other.day)
            return true;
        else
            return false;
    }
};

// ---------- MAIN FUNCTION ----------
int main() {
    try {
        int d1, m1, y1;
        int d2, m2, y2;

        printf("Enter first date (dd mm yyyy): ");
        scanf("%d %d %d", &d1, &m1, &y1);

        // Constructor may throw an exception
        Date date1(d1, m1, y1);

        printf("Enter second date (dd mm yyyy): ");
        scanf("%d %d %d", &d2, &m2, &y2);

        Date date2(d2, m2, y2);

        printf("\nFirst Date: ");
        date1.printDate();
        printf("Second Date: ");
        date2.printDate();

        // Comparison using overloaded operator
        if (date1 < date2)
            printf("First date is earlier than second date.\n");
        else if (date2 < date1)
            printf("Second date is earlier than first date.\n");
        else
            printf("Both dates are the same.\n");

    } catch (const invalid_argument& e) {
        printf("Error: %s\n", e.what());
    }

    return 0;
}
