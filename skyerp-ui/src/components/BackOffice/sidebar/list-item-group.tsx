import React from "react";
import SidebarListItem from "./list-item";
import { ExpandLess, ExpandMore } from "@mui/icons-material";
import { Collapse, List, ListItem, ListItemIcon, ListItemText } from "@mui/material";

interface Item {
  route: string
  text: string;
  icon: any;
};
interface Props {
  text: string;
  items: Item[];
  icon: any;
};

const SidebarListItemGroup: React.FC<Props> = ({ text, items, icon }) => {
  //let { text, icon, items, nestedItemClass } = props;

  const [open, setOpen] = React.useState(false);

  let itemsList = items.map((item, index) => {
    return (
      <SidebarListItem
        key={index}
        route={item.route}
        text={item.text}
        icon={item.icon}
      />
    );
  });
  const handleClick = () => {
    setOpen(!open);
  };

  return (
    <>
      <ListItem button onClick={handleClick}>
        <ListItemIcon>{React.createElement(icon)}</ListItemIcon>
        <ListItemText primary={text} />
        {open ? <ExpandLess /> : <ExpandMore />}
      </ListItem>
      <Collapse in={open} timeout="auto" unmountOnExit>
        <List component="div" disablePadding>
          {itemsList}
        </List>
      </Collapse>
    </>
  );
}

export default SidebarListItemGroup;