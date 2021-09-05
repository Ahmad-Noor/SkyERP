import {
  DashboardRounded,
  VerifiedUser,
  SupervisedUserCircle,
  InvertColorsRounded,
  FormatItalic,
  AccountCircle,
  ShoppingCart,
  Dvr,
  ShopTwoSharp,
} from "@mui/icons-material";

const SidebarItemsList = () => {
  return [
    {
      text: "Dashboard",
      route: "/",
      icon: DashboardRounded,
    },
    {
      text: "Users",
      icon: VerifiedUser,
      items: [
        {
          text: "Users List",
          route: "/UsersList",
          icon: SupervisedUserCircle,
        },
        {
          text: "Users",
          route: "/Users",
          icon: SupervisedUserCircle,
        },
      ],
    },
    {
      text: "Inventory",
      icon: InvertColorsRounded,
      items: [
        { text: "Items List", route: "/Items", icon: ShopTwoSharp },
        { text: "Transfer In", route: "/Items", icon: FormatItalic },
        { text: "Transfer Out", route: "/Items", icon: FormatItalic },
      ],
    },
    {
      text: "Purchases",
      icon: InvertColorsRounded,
      items: [
        { text: "Suppliers", route: "/Suppliers", icon: ShoppingCart },
        { text: "Purchases", route: "/Purchases", icon: ShoppingCart },
        {
          text: "Purchases Return",
          route: "/PurchasesReturn",
          icon: ShoppingCart,
        },
      ],
    },
    {
      text: "Sales",
      icon: InvertColorsRounded,
      items: [
        { text: "Customers", route: "/Customers", icon: AccountCircle },
        { text: "Sales", route: "/Sales", icon: AccountCircle },
        {
          text: "Sales Return",
          route: "/CustomersReturn",
          icon: AccountCircle,
        },
      ],
    },
    {
      text: "POS",
      icon: InvertColorsRounded,
      items: [
        { text: "POS", route: "/POS", icon: Dvr },
        {
          text: "Shift Transaction",
          route: "/ShiftTransaction",
          icon: Dvr,
        },
        {
          text: "Delivery Orders",
          route: "/DeliveryOrders",
          icon: AccountCircle,
        },
      ],
    },
    {
      text: "Settings",
      icon: InvertColorsRounded,
      items: [
        { text: "Companies", route: "/Companies", icon: AccountCircle },
        { text: "Settings", route: "/Settings", icon: AccountCircle },
      ],
    },
  ];
};
export default SidebarItemsList();
