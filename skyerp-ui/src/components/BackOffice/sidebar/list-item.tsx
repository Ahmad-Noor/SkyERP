import React from "react";
import { Link, ListItem, ListItemIcon, ListItemText } from "@mui/material";

interface Props {
  route: string
  text: string;
  icon: any;
};

const SidebarListItem: React.FC<Props> = ({ text, route, icon }) => {

  return (
    <ListItem style={{ paddingLeft: "32px" }} button component={Link} href={route}>
      <ListItemIcon>{React.createElement(icon)}</ListItemIcon>
      <ListItemText primary={text} />
    </ListItem>
  );
}
export default SidebarListItem;